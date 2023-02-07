using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Models.BD;

namespace Controllers.FillInv
{

    public class FillEquipo
    {
        ////LISTA DE EQUIPOS full
        //public IEnumerable<Models.ViewModels.ProductoViewModel> EquiposGetList()
        //{
        //    using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
        //    {
        //        IEnumerable<Models.ViewModels.ProductoViewModel> lst = (from d in db.EquipoUnico
        //                                                                select new Models.ViewModels.ProductoViewModel
        //                                                                {
        //                                                                    ID_Equipo = d.ID_Equipo,
        //                                                                    Num_Serie = d.Num_Serie,
        //                                                                    Activo = d.Activo,
        //                                                                    Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
        //                                                                    Inventario_LabID_Lab = d.Inventario_LabID_Lab
        //                                                                }).ToList();
        //        return lst;
        //    }
        //}

        //public IEnumerable<Models.ViewModels.ProductoViewModel> EquiposGetList1(int xd)
        //{
        //    using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
        //    {
        //        IEnumerable<Models.ViewModels.ProductoViewModel> lst = (from d in db.EquipoUnico
        //                                                                where d.Inventario_LabID_Lab == xd
        //                                                                select new Models.ViewModels.ProductoViewModel
        //                                                                {
        //                                                                    ID_Equipo = d.ID_Equipo,
        //                                                                    Num_Serie = d.Num_Serie,
        //                                                                    Activo = d.Activo,
        //                                                                    Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
        //                                                                    Inventario_LabID_Lab = d.Inventario_LabID_Lab
        //                                                                }).ToList();
        //        return lst;
        //    }
        //}

        //public IEnumerable<Models.ViewModels.ProductoViewModel> EquiposGetList2(int xd)
        //{
        //    using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
        //    {
        //        IEnumerable<Models.ViewModels.ProductoViewModel> lst = (from d in db.EquipoUnico
        //                                                                where d.Tipo_ArticuloID_Articulo == xd
        //                                                                select new Models.ViewModels.ProductoViewModel
        //                                                                {
        //                                                                    ID_Equipo = d.ID_Equipo,
        //                                                                    Num_Serie = d.Num_Serie,
        //                                                                    Activo = d.Activo,
        //                                                                    Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
        //                                                                    Inventario_LabID_Lab = d.Inventario_LabID_Lab
        //                                                                }).ToList();
        //        return lst;
        //    }
        //}

        //public IEnumerable<Models.ViewModels.ProductoViewModel> EquiposGetList3(int xd, int dx)
        //{
        //    using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
        //    {
        //        IEnumerable<Models.ViewModels.ProductoViewModel> lst = (from d in db.EquipoUnico
        //                                                                where d.Tipo_ArticuloID_Articulo == xd && d.Inventario_LabID_Lab == dx
        //                                                                select new Models.ViewModels.ProductoViewModel
        //                                                                {
        //                                                                    ID_Equipo = d.ID_Equipo,
        //                                                                    Num_Serie = d.Num_Serie,
        //                                                                    Activo = d.Activo,
        //                                                                    Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
        //                                                                    Inventario_LabID_Lab = d.Inventario_LabID_Lab
        //                                                                }).ToList();
        //        return lst;
        //    }
        //}
    }
}