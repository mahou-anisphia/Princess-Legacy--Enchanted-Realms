namespace PrincessLegacyEnchantedRealms.clientDataManager
{
    public class GameObjects
    {
        private string _describtion;
        private string _name;
        private string _images;
        public GameObjects(string describtion, string name, string images)
        {
            _describtion = describtion;
            _name = name;
            _images = $@"{images}";
            //convert to formatted plain string, remove escapers
        }
        public string Name
        {
            get => _name;
        }
        public string ShortDescribtion{
            get => _describtion;
        }
        public string GetSetAvatar
        {
            get => _images;
            set => _images = value;
        }
    }
}
