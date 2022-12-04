using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KullaniciManager:IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public IResult Add(Kullanicis t)
        {
            _kullaniciDal.Add(t);
            return new SuccessResult("Ekleme islemi basarili");
        }

        public IResult Delete(Kullanicis t)
        {
            _kullaniciDal.Delete(t);
            return new SuccessResult("Silme islemi basaarili");
        }

        public IDataResult<List<Kullanicis>> GetAll()
        {
            return new SuccessDataResult<List<Kullanicis>>(_kullaniciDal.GetAll());
        }

        public IDataResult<Kullanicis> GetById(int id)
        {
            return new SuccessDataResult<Kullanicis>(_kullaniciDal.Get(x => x.Id == id));
        }

        public IResult Update(Kullanicis t)
        {
            _kullaniciDal.Update(t);
            return new SuccessResult("Guncelleme islemi basarili.");
        }

        IResult IBaseService<Kullanicis>.Add(Kullanicis t)
        {
            throw new NotImplementedException();
        }

        IResult IBaseService<Kullanicis>.Delete(Kullanicis t)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Kullanicis>> IBaseService<Kullanicis>.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Kullanicis> IBaseService<Kullanicis>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IResult IBaseService<Kullanicis>.Update(Kullanicis t)
        {
            throw new NotImplementedException();
        }
    }
}
