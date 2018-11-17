namespace AssetPacker.Command
{
    public class NewProject : ICommand
    {
        private MainForm form;

        public NewProject(MainForm form)
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

            if (form.project != null && form.dirty)
            {
                if (!form.project.ShowConfirm(form.FormToProjectSetting))
                    return;
            }

            form.ClearForm();

            Model.Project newProject = new Model.Project();
            newProject.Save();
            if (string.IsNullOrEmpty(newProject.Path))
            {
                return;
            }

            form.project = newProject;

            form.RefreshAssetList();
            form.UpdateMenuEnable();
            form.ProjectSettingToForm();

            form.dirty = false;
            form.UpdateTitle();
        }
    }
}
