namespace Foody.BusinessLayer.Abstract;

public interface IGenericService<T> where T : class
{
    //crud
    void TInsert(T entity);
    void TUpdate(T entity);
    void TDelete(int id);
    List<T> TGetAll();
    T TGetById(int id);
}