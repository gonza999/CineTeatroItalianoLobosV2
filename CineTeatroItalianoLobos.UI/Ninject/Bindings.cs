﻿using Ninject.Modules;
using CineTeatroItalianoLobos.Data;
using CineTeatroItalianoLobos.DataComun;
using CineTeatroItalianoLobos.DataComun.Facades;
using CineTeatroItalianoLobos.Services.Facades;
using CineTeatroItalianoLobos.Services;
using CineTeatroItalianoLobos.Data.Repositories;

namespace CineTeatroItalianoLobos.UI.Ninject
{
    public class Bindins : NinjectModule
    {
        public override void Load()
        {
            Bind<CineTeatroDbContext>().ToSelf().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IRepositorioTipoEventos>().To<TiposDeEventosRepositorio>();
            Bind<ITiposDeEventosServicios>().To<TiposDeEventosServicios>();

            Bind<IRepositorioClasificaciones>().To<ClasificacionesRepositorio>();
            Bind<IClasificacionesServicio>().To<ClasificacionesServicio>();

            Bind<IRepositorioUbicaciones>().To<UbicacionesRepositorio>();
            Bind<IUbicacionesServicio>().To<UbicacionesServicio>();

            Bind<IRepositorioFormasVentas>().To<FormasVentasRepositorio>();
            Bind<IFormasVentasServicio>().To<FormasVentasServicio>();

            //Bind<IRepositorioEmpleados>().To<ClientesRepositorio>();
            //Bind<IClientesServicios>().To<ClientesServicios>();

            //Bind<IRepositorioEventos>().To<ProveedoresRepositorio>();
            //Bind<IProveedoresServicios>().To<ProveedoresServicios>();

            //Bind<IRepositorioFormasPagos>().To<ProductosRepositorio>();
            //Bind<IProductosServicios>().To<ProductosServicios>();

            //Bind<IRepositorioFormasVentas>().To<OrdenesRepositorio>();
            //Bind<IOrdenesServicios>().To<OrdenesServicios>();

            //Bind<IRepositorioHorarios>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioLocalidades>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioPlantas>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioTickets>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();


            //Bind<IRepositorioTiposDocumentos>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioUbicaciones>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioVentas>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IRepositorioVentasTickets>().To<PaisesReportes>();
            //Bind<ICategoriasReportes>().To<CategoriasReportes>();

            //Bind<IManejadorDeReportes>().To<ManejadorDeReportes>();

        }
    }
}