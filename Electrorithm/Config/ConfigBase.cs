using AppStudio.DataProviders;

namespace Electrorithm.Config
{
    public abstract class ConfigBase<T> where T : SchemaBase
    {
        public abstract DataProviderBase<T> DataProvider { get; }

        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}
