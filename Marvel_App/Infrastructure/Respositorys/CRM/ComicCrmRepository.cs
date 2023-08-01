using Marvel_App.Domain.Repository;
using Marvel_App.Infrastructure.Services;

namespace Marvel_App.Infrastructure.Respositorys.CRM
{
    public class ComicCrmRepository : IComicsRepository //En esta clase irian las implementaciones de los servicios
    {
        CrmService _crmService; //1*

        public ComicCrmRepository(CrmService crmService) //Cada que se inyecta un parametro por constructor se debe seguir la estructura de 1* y 2*
        {

            _crmService = crmService; //2* Si fuera privado se usaria This.crmService en vez del _ 

        }

        void IComicsRepository.Create(arc_comic arc_Comic)
        {
            throw new System.NotImplementedException();
        }

        arc_comic IComicsRepository.ObtainForId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
