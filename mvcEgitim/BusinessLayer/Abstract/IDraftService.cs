using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDraftService
    {
        List<Draft> GetListDraftBox();
    
        void DraftAdd(Draft message);
        Draft GetById(int id);
        void DraftDelete(Draft message);
        void DraftUpdate(Draft message);
    }
}
