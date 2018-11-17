using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class OpenSourceDir : ICommand
    {
        private MainForm form;

        public OpenSourceDir(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return true;
        }

        public void Execute()
        {
            if (!Check())
                return;

            var dlg = new FolderBrowserDialog()
            {
                SelectedPath = form.project.MakeAbsolutePath(""),
            };
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            if (string.IsNullOrEmpty(dlg.SelectedPath))
                return;

            form.txtPackPath.Text = dlg.SelectedPath;
            form.dirty = true;
            form.UpdateTitle();
        }
    }
}
