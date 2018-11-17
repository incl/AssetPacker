namespace AssetPacker.Command
{
    public class SaveProjectAs : ICommand
    {
        private MainForm form;

        public SaveProjectAs(MainForm form)
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
            if (form.project.SaveAs())
                form.project.Save();

            form.dirty = false;
            form.UpdateTitle();
        }
    }
}
