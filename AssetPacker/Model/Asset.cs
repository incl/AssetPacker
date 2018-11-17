namespace AssetPacker.Model
{
    public class Asset
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Atlas Atlas { get; set; }

        public Asset()
        {
            Name = "";
            Path = "";
            Atlas = new Atlas();
        }

        public new string ToString()
        {
            return Name;
        }

        public void Save()
        {
            if (Atlas != null)
            {
                foreach (var sprite in Atlas.Sprites)
                {
                    if (sprite.Offset.X != 0 || sprite.Offset.Y != 0)
                    {
                        if (Atlas.Offsets.ContainsKey(sprite.ImageName))
                            Atlas.Offsets[sprite.ImageName] = sprite.Offset;
                        else
                            Atlas.Offsets.Add(sprite.ImageName, sprite.Offset);
                    }
                }
            }
        }
    }
}
