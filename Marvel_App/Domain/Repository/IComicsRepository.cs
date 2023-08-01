namespace Marvel_App.Domain.Repository //Contratos
{
    public interface IComicsRepository
    {
        void Create(arc_comic arc_Comic);

        arc_comic ObtainForId(int id);

    }
}
