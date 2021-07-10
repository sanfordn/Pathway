using Pathway.DTOs;

namespace Domain
{
    public interface IStoreInfo
    {
        public void CreateStore();
        public Store GetStoreInfo(string Name);
    }
}
