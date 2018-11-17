namespace AssetPacker.Command
{
    public class SaveProject : ICommand
    {
        private MainForm form;

        public SaveProject(MainForm form)
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

            form.FormToProjectSetting();
            form.project.Save();
            form.dirty = false;
            form.UpdateTitle();
        }
    }
}
