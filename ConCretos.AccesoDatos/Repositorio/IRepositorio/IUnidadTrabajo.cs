using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCretos.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        //Aqui se van gregar todos los nuevos modelos
        IBodegaRepositorio Bodega { get; }
        ICategoriaRepositorio Categoria { get; }

        IMarcaRepositorio Marca { get; }
        Task Guardar();
    }

}
