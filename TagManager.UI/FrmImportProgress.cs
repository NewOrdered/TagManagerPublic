using System;
using System.ComponentModel;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI
{
    public partial class FrmImportProgress : Form
    {
        public FrmImportProgress(TagStorage tagStorage, string filePath)
        {
            InitializeComponent();
            _tagStorage = tagStorage;
            _filePath = filePath;
            InitializeWorker();
        }

        private TagStorage _tagStorage;
        private string _filePath;
        private BackgroundWorker worker;
        public ReturnResult Result;

        private void InitializeWorker()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.WorkerReportsProgress = true;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Result = _tagStorage.ImportItems(_filePath);
        }

        private void FrmImportProgress_Load(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }
    }
}
