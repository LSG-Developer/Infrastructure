using LSG.Framework.Factory.CastleWindsor;

namespace LSG.Framework.Service.Base
{
    public abstract class ServiceBase
    {
        public static T CastleFactory<T>(string xml_castle_file_name)
        {
            T repository = CastleWinsorFactory<T>.Create(xml_castle_file_name);
            return repository;
        }
    }
}
