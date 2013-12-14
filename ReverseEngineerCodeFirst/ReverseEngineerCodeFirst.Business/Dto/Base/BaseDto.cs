using System.Collections.Generic;
using System.Linq;

namespace ReverseEngineerCodeFirst.Business.Dto.Base
{
  public abstract class BaseDto<T>
  {
    public static BaseDto<T> From(T entity)
    {
      return default(BaseDto<T>);
      //return new BaseDto<T>().FromInternal(entity);
    }

    public static IList<BaseDto<T>> From(IList<T> entities)
    {
      return entities.Select(From).ToList();
    }

    protected abstract BaseDto<T> FromInternal(T entity);
  }
}
