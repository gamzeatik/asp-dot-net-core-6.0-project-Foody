using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class AddressManager : IAddressService
{
    private readonly IAddressDal _addressDal;

    public AddressManager(IAddressDal addressDal)
    {
        _addressDal = addressDal;
    }

    public void TInsert(Address entity)
    {
        _addressDal.Insert(entity);
    }

    public void TUpdate(Address entity)
    {
        _addressDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _addressDal.Delete(id);
    }

    public List<Address> TGetAll()
    {
        return _addressDal.GetAll();
    }

    public Address TGetById(int id)
    {
        return _addressDal.GetById(id);
    }
}