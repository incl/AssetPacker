using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class OpenProject : ICommand
    {
        private MainForm form;

        public OpenProject(MainForm form)
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

            if (form.project != null 
                && form.dirty
                && !form.project.ShowConfirm(form.FormToProjectSetting))
                return;

            var dlg = new OpenFileDialog()
            {
                Filter = string.Format("{0} files (*{0})|*{0}", Model.Project.Ext)
            };
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            string openPath = dlg.FileName;
            if (string.IsNullOrEmpty(openPath))
                return;

            string json = System.IO.File.ReadAllText(openPath);
            form.project = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Project>(json);

            if (form.project == null)
                form.project = new Model.Project();
            
            form.ClearForm();

            form.project.Open();
            form.ProjectSettingToForm();
            form.RefreshAssetList();
            form.UpdateMenuEnable();
            form.dirty = false;
            form.UpdateTitle();
        }
    }
}
