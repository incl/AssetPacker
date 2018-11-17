using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class AddAsset : ICommand
    {
        private MainForm form;

        public AddAsset(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.project != null;
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

            form.project.AddAsset(dlg.SelectedPath);
            form.RefreshAssetList();
            form.dirty = true;
            form.UpdateTitle();
        }
    }
}
