using GroupDocs.Viewer.Exceptions;
using GroupDocs.Viewer.Options;
using GroupsDocs.Viewer.Forms.UI;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Drawing;

namespace GroupDocs.Viewer.Forms.UI
{
    /// <summary>
    /// Main application form.
    /// </summary>
    public partial class MainForm : Form
    {
        private string CurrentFilePath { get; set; }
        private Results.ViewInfo ViewInfo { get; set; }

        private MemoryPageStreamFactory MemoryPageStreamFactory { get; set; }

        private GroupDocs.Viewer.Viewer Viewer { get; set; }

        private int CurrentPage { get; set; } = 1;

        const string GeneralTitle = "Viewer for .NET  Windows Forms";

        public MainForm()
        {
            InitializeComponent();
            SetLicense();
            UpdateControlsVisibility();

            // Set title.
            Text = GeneralTitle;
            MemoryPageStreamFactory = new MemoryPageStreamFactory();

            //WebView2
            AttachControlEventHandlers(this.webView2Control);
            HandleResize();

        }

        /// <summary>
        /// Update controls visibility.
        /// </summary>
        private void UpdateControlsVisibility()
        {
            // If viewinfo != null (document loaded) - enable all page buttons.
            firstPageBtn.Enabled = lastPageBtn.Enabled = prevPageBtn.Enabled = nextPageBtn.Enabled = (ViewInfo != null);

            // If viewinfo != null (document loaded) and document with 1 or more pages - all buttons should be visible.
            firstPageBtn.Visible = lastPageBtn.Visible = prevPageBtn.Visible = nextPageBtn.Visible = (ViewInfo != null && ViewInfo.Pages.Count > 1);

            if (ViewInfo != null)
            {
                firstPageBtn.Enabled = lastPageBtn.Enabled = (ViewInfo.Pages.Count > 0);

                if (CurrentPage <= 1)
                {
                    firstPageBtn.Enabled = false;
                }

                if (CurrentPage > 1)
                {
                    firstPageBtn.Enabled = true;
                }

                lastPageBtn.Enabled = (ViewInfo.Pages.Count != CurrentPage) && (ViewInfo.Pages.Count > 0);

                prevPageBtn.Enabled = (CurrentPage != 1);
                nextPageBtn.Enabled = (CurrentPage != ViewInfo.Pages.Count);
            }
        }

        /// <summary>
        /// Set GroupDocs.Viewer license.
        /// </summary>
        private void SetLicense()
        {
            string fileName = "GroupDocs.Viewer.lic";

            if (File.Exists(fileName))
            {
                GroupDocs.Viewer.License license = new License();
                license.SetLicense(fileName);
                SetLabelText(licenseStatusLabel, "Licensed");
            }
        }

        /// <summary>
        /// Open file button click event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Title = "Import File";
                openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|" +
                            "Documents (*.PDF;*.DOC;*.DOCX;*.TXT;*.XLSX)|*.PDF;*.DOC;*.DOCX;*.TXT;*.XLSX|" +
                            "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = openFileDialog.FileName;
                    openFileBtn.Enabled = false;
                }
            }

            ProcessImportFile(CurrentFilePath);

            //WebView2
            if (!string.IsNullOrEmpty(CurrentFilePath) && webView2Control != null && webView2Control.CoreWebView2 != null)
            {
                txtUrl.Text = $"file:///{CurrentFilePath.Replace('/', '\\')}";
                webView2Control.CoreWebView2.Navigate(txtUrl.Text);
            }

        }

        private void ProcessImportFile(string processingFile)
        {
            // If file set - process it.
            if (!string.IsNullOrEmpty(processingFile))
            {

                if (Viewer != null)
                {
                    Viewer.Dispose();
                    ViewInfo = null;
                    CurrentPage = 1;
                    DisplayViewInfo();
                }

                //new Thread(() =>
                //{
                try
                {
                    SetPagesInfoText($"Loading {Path.GetFileName(processingFile)}");

                    Viewer = new GroupDocs.Viewer.Viewer(processingFile);
                    GroupDocs.Viewer.Options.ViewInfoOptions viewInfo = GroupDocs.Viewer.Options.ViewInfoOptions.ForHtmlView();

                    try
                    {
                        ViewInfo = Viewer.GetViewInfo(viewInfo);
                    }
                    catch (PasswordRequiredException)
                    {
                        // Ask for password
                        EnterPasswordBox enterPasswordbox = new EnterPasswordBox();
                        DialogResult res = enterPasswordbox.ShowDialog();

                        if (res == DialogResult.OK)
                        {
                            Viewer.Dispose();
                            ViewInfo = null;

                            LoadOptions loadOptions = new LoadOptions();
                            loadOptions.Password = enterPasswordbox.ResultValue;

                            Viewer = new GroupDocs.Viewer.Viewer(processingFile, loadOptions);
                            ViewInfo = Viewer.GetViewInfo(viewInfo);
                        }
                        else
                        {
                            ViewInfo = null;
                            CurrentFilePath = null;
                            webBrowerMain.DocumentText = string.Empty;
                            DisplayViewInfo();

                            throw;
                        }
                    }

                    ViewFile(Viewer);
                    openFileBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured! {ex.Message}");
                    ViewInfo = null;
                    DisplayViewInfo();
                    openFileBtn.Enabled = true;
                    return;
                }
                //}).Start();

            }
        }

        /// <summary>
        /// View file.
        /// </summary>
        /// <param name="viewer">Viewer object.</param>
        /// <param name="page">Page number to view.</param>
        private void ViewFile(Viewer viewer, int page = 1)
        {
            if (ViewInfo != null)
            {
                HtmlViewOptions htmlViewOptions = HtmlViewOptions.ForEmbeddedResources(MemoryPageStreamFactory);
                viewer.View(htmlViewOptions, page);

                MemoryPageStreamFactory.Stream.Position = 0;
                webBrowerMain.DocumentStream = MemoryPageStreamFactory.Stream;
            }

            UpdateControlsVisibility();
            DisplayViewInfo();
        }

        /// <summary>
        /// Display current file view info (current page, total pages, file name).
        /// </summary>
        private void DisplayViewInfo()
        {
            if (ViewInfo != null)
            {
                SetPagesInfoText($"{CurrentPage}/{ViewInfo.Pages.Count}");
                SetFormTitle(Path.GetFileName(CurrentFilePath));
            }
            else
            {
                SetPagesInfoText(" ");
                SetFormTitle("No document loaded.");
            }
        }

        /// <summary>
        /// Set form title.
        /// </summary>
        /// <param name="text"></param>
        private void SetFormTitle(string text)
        {
            this.Text = GeneralTitle + " - " + text;
        }

        /// <summary>
        /// Set pages info text.
        /// </summary>
        /// <param name="text"></param>
        private void SetPagesInfoText(string text)
        {
            pagesStatusLabel.Text = text;
        }

        /// <summary>
        /// Set tool strip label text.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void SetLabelText(ToolStripLabel control, string text)
        {
            control.Text = text;

        }

        /// <summary>
        /// First page button click event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            ViewFile(Viewer, CurrentPage);
        }

        /// <summary>
        /// Previous page button click event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage != 1)
            {
                CurrentPage = CurrentPage - 1;
                ViewFile(Viewer, CurrentPage);
            }
        }

        /// <summary>
        /// Next page button click event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage != ViewInfo.Pages.Count)
            {
                CurrentPage = CurrentPage + 1;
                ViewFile(Viewer, CurrentPage);
            }
        }

        /// <summary>
        /// Last page button click event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            CurrentPage = ViewInfo.Pages.Count;
            ViewFile(Viewer, CurrentPage);
        }

        /// <summary>
        /// Form closing event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Form closing event arguments.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose viewer object if not null
            if (Viewer != null)
            {
                Viewer.Dispose();
            }
        }


        #region WebView2

        private void HandleResize()
        {
            // Move the Events button
            btnEvents.Left = this.ClientSize.Width - btnEvents.Width;
            // Move the Go button
            btnGo.Left = this.btnEvents.Left - btnGo.Size.Width;

            // Resize the URL textbox
            txtUrl.Width = btnGo.Left - txtUrl.Left;
        }

        private void UpdateTitleWithEvent(string message)
        {
            string currentDocumentTitle = this.webView2Control?.CoreWebView2?.DocumentTitle ?? "Uninitialized";
            this.Text = currentDocumentTitle + " (" + message + ")";
        }

        private void WebView2Control_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            UpdateTitleWithEvent("NavigationStarting");
        }

        private void WebView2Control_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            UpdateTitleWithEvent("NavigationCompleted");
        }

        private void WebView2Control_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            txtUrl.Text = webView2Control.Source.AbsoluteUri;
        }

        private void WebView2Control_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                MessageBox.Show($"WebView2 creation failed with exception = {e.InitializationException}");
                UpdateTitleWithEvent("CoreWebView2InitializationCompleted failed");
                return;
            }

            this.webView2Control.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
            this.webView2Control.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
            this.webView2Control.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
            this.webView2Control.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Image);
            UpdateTitleWithEvent("CoreWebView2InitializationCompleted succeeded");
        }

        void AttachControlEventHandlers(Microsoft.Web.WebView2.WinForms.WebView2 control)
        {
            control.CoreWebView2InitializationCompleted += WebView2Control_CoreWebView2InitializationCompleted;
            control.NavigationStarting += WebView2Control_NavigationStarting;
            control.NavigationCompleted += WebView2Control_NavigationCompleted;
            control.SourceChanged += WebView2Control_SourceChanged;
            control.KeyDown += WebView2Control_KeyDown;
            control.KeyUp += WebView2Control_KeyUp;
        }

        private void WebView2Control_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTitleWithEvent($"AcceleratorKeyUp key={e.KeyCode}");
            if (!this.acceleratorKeysEnabledToolStripMenuItem.Checked)
                e.Handled = true;
        }

        private void WebView2Control_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateTitleWithEvent($"AcceleratorKeyDown key={e.KeyCode}");
            if (!this.acceleratorKeysEnabledToolStripMenuItem.Checked)
                e.Handled = true;
        }

        private void CoreWebView2_HistoryChanged(object sender, object e)
        {
            // No explicit check for webView2Control initialization because the events can only start
            // firing after the CoreWebView2 and its events exist for us to subscribe.
            btnBack.Enabled = webView2Control.CoreWebView2.CanGoBack;
            btnForward.Enabled = webView2Control.CoreWebView2.CanGoForward;
            UpdateTitleWithEvent("HistoryChanged");
        }

        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            this.txtUrl.Text = this.webView2Control.Source.AbsoluteUri;
            UpdateTitleWithEvent("SourceChanged");
        }

        private void CoreWebView2_DocumentTitleChanged(object sender, object e)
        {
            this.Text = this.webView2Control.CoreWebView2.DocumentTitle;
            UpdateTitleWithEvent("DocumentTitleChanged");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webView2Control.Reload();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            var rawUrl = txtUrl.Text;
            Uri uri = null;

            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                uri = new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                // An invalid URI contains a dot and no spaces, try tacking http:// on the front.
                uri = new Uri("http://" + rawUrl);
            }
            else
            {
                // Otherwise treat it as a web search.
                uri = new Uri("https://bing.com/search?q=" +
                    String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }

            webView2Control.Source = uri;

            //GroupDocs
            var localFile = rawUrl;
            if (!localFile.Contains("file:///") || !Path.HasExtension(localFile))
                return;

            localFile = localFile.Substring(8, localFile.Length - 8).Replace('/', '\\');
            var localFileExt = Path.GetExtension(localFile);

            if (string.IsNullOrWhiteSpace(localFile) || string.IsNullOrWhiteSpace(localFileExt))
                return;

            ProcessImportFile(localFile);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webView2Control.GoBack();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            (new EventMonitor(this.webView2Control)).Show(this);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webView2Control.GoForward();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            HandleResize();
        }

        private void xToolStripMenuItem05_Click(object sender, EventArgs e)
        {
            this.webView2Control.ZoomFactor = 0.5;
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.webView2Control.ZoomFactor = 1.0;
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.webView2Control.ZoomFactor = 2.0;
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Zoom factor: {this.webView2Control.ZoomFactor}", "WebView Zoom factor");
        }

        private void backgroundColorMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            Color backgroundColor = Color.FromName(menuItem.Text);
            this.webView2Control.DefaultBackgroundColor = backgroundColor;
        }

        private void allowExternalDropMenuItem_Click(object sender, EventArgs e)
        {
            //No longer support for WebView2 release nupkg
            //this.webView2Control.AllowExternalDrop = this.allowExternalDropMenuItem.Checked;
        }

        #endregion
    }
}
