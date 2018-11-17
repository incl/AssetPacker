using System.Collections.Generic;

namespace AssetPacker.Command
{
    public class DeleteAsset : ICommand
    {
        private MainForm form;

        public DeleteAsset(MainForm form)
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

            List<Model.Asset> removeItems = form.GetSelectedAssetList();
            foreach (var item in removeItems)
            {
                form.project.Assets.Remove(item);
            }
            form.RefreshAssetList();
        }
    }
}
