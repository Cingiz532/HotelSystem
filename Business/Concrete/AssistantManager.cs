using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AssistantManager(IAssistantDal assistantDal) : IAssistantManager
    {
        private readonly IAssistantDal _assistantDal=assistantDal;
        public IResult Add(Assistant assistant)
        {
            if(assistant.FirstName.Length>3 && assistant.Age>=18)
            {
                _assistantDal.Add(assistant);
                return new SuccessResult("Assistant ugurla elave olundu...");
            }
            else
            {
                return new ErrorResult("Assistant adi en azi 5 , assistant yashi en azi 18 olmalidir...");
            }
        }
        public IResult Delete(int id)
        {
            var text = _assistantDal.GetById(a => a.Id == id);
            if (text != null)
            {
                _assistantDal.Delete(text);
                return new SuccessResult("Assistant silindi...");
            }
            else
            {
                return new ErrorResult("Assistant tapilmadi...");
            }
        }
        public IDataResult<List<Assistant>> GetAll()
        {
           List<Assistant>assistants = _assistantDal.GetAll(a => a.IsActive == true);
           if(assistants!=null)
            {
                return new SuccessDataResult<List<Assistant>>("Assistantlar siyahisi hazirdir...",assistants);
            }
           else
            {
                return new ErrorDataResult<List<Assistant>>("Xeta bash verdi",assistants);
            }
        }
        public IDataResult<Assistant> GetById(int id)
        {
            var text = _assistantDal.GetById(a => a.IsActive == true && a.Id == id);
            if(text != null)
            {
                return new SuccessDataResult<Assistant>("Assistant tapildi...",text);
            }
            else
            {
                return new ErrorDataResult<Assistant>("Assistant tapilmadi",text);
            }
        }
        public void Update(Assistant assistant)
        {
            var text = _assistantDal.GetById(a=>a.Id==assistant.Id);
            if(text != null)
            {
                _assistantDal.Update(assistant);
            }
            else
            {
                throw new Exception("A.Invalid Operation...");
            }
        }
    }
}
