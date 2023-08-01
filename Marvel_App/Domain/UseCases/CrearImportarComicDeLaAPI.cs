using Marvel_App.Domain.Repository;

namespace Marvel_App.Domain.UseCases
{
    public class CrearImportarComicDeLaAPI
    {
        IComicsRepository _comicsRepository;

        public CrearImportarComicDeLaAPI(IComicsRepository comicsRepository)
        {

            _comicsRepository = comicsRepository;

        }

        public void invoke(arc_comic arc_Comic)
        {

            _comicsRepository.Create(arc_Comic);

        }

    }

}
