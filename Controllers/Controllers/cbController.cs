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
using System.Globalization;

namespace Controllers
{
    public class cbController
    {
        #region Obtener lista para los ComboBox
            //LISTA DE TODOS LOS LABORATORIOS DEFAULT
        public IEnumerable<Models.ViewModels.LabViewModel> LabGetList()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.LabViewModel> lst = (from d in db.Inventario_Lab
                                                                   where d.Activo == true
                                                                   select new Models.ViewModels.LabViewModel
                                                                   {
                                                                       ID_Lab = d.ID_Lab,
                                                                       Nom_Lab = d.Nom_Lab
                                                                   }).ToList();
                return lst;
            }
        }

            //LISTA DE TODOS LOS ARTICULOS DEFAULT
        public IEnumerable<Models.ViewModels.ArticuloViewModel> ArtGetList()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.ArticuloViewModel> lst = (from d in db.Tipo_Articulo
                                                                        where d.Activo == true
                                                                        select new Models.ViewModels.ArticuloViewModel
                                                                        {
                                                                            ID_Articulo = d.ID_Articulo,
                                                                            Nom_Articulo = d.Nom_Articulo
                                                                        }).ToList();
                return lst;
            }
        }

            //MOSTRAR ARTICULOS DEPENDIENDO DEL LABORATORIO SELECCIONADO
        public IEnumerable<Models.ViewModels.ARTxLAB> Art_por_Lab(int xd)
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.ARTxLAB> lst = (from a in db.Tipo_Articulo
                                                              join e in db.EquipoUnico on a.ID_Articulo equals e.Tipo_ArticuloID_Articulo
                                                              where e.Inventario_LabID_Lab == xd && e.Activo== true
                                                              select new Models.ViewModels.ARTxLAB
                                                              {
                                                                  ID_Articulo = a.ID_Articulo,
                                                                  Nom_Articulo = a.Nom_Articulo
                                                              }).Distinct().ToList();
                return lst;
            }
        }
        #endregion


        #region Obtener lista de EQUIPOS para los DataGrid
            //lISTA DE EQUIPOS DEFAULT (SIN LOS ACTIVOS = FALSO)
        public IEnumerable<Models.ViewModels.EquiposViewModel> EquiposGetList()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.EquiposViewModel> lst = (from d in db.EquipoUnico
                                                                       where d.Activo == true
                                                                       select new Models.ViewModels.EquiposViewModel
                                                                        {
                                                                            ID_Equipo = d.ID_Equipo,
                                                                            Num_Serie = d.Num_Serie,
                                                                            Activo = d.Activo,
                                                                            Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
                                                                            Inventario_LabID_Lab = d.Inventario_LabID_Lab
                                                                        }).ToList();
                return lst;
            }
        }

            //Obtener lista de equipos por LAB
        public IEnumerable<Models.ViewModels.EquiposViewModel> EquiposGetList1(int xd)
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.EquiposViewModel> lst = (from d in db.EquipoUnico
                                                                       where d.Inventario_LabID_Lab == xd && d.Activo == true
                                                                       select new Models.ViewModels.EquiposViewModel
                                                                        {
                                                                            ID_Equipo = d.ID_Equipo,
                                                                            Num_Serie = d.Num_Serie,
                                                                            Activo = d.Activo,
                                                                            Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
                                                                            Inventario_LabID_Lab = d.Inventario_LabID_Lab
                                                                        }).ToList();
                return lst;
            }
        }
            //Obtener lista de equipos por ART
        public IEnumerable<Models.ViewModels.EquiposViewModel> EquiposGetList2(int xd)
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.EquiposViewModel> lst = (from d in db.EquipoUnico
                                                                        where d.Tipo_ArticuloID_Articulo == xd && d.Activo == true
                                                                       select new Models.ViewModels.EquiposViewModel
                                                                        {
                                                                            ID_Equipo = d.ID_Equipo,
                                                                            Num_Serie = d.Num_Serie,
                                                                            Activo = d.Activo,
                                                                            Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
                                                                            Inventario_LabID_Lab = d.Inventario_LabID_Lab
                                                                        }).ToList();
                return lst;
            }
        }

            //Obtener lista de equipos por LAB Y ART
        public IEnumerable<Models.ViewModels.EquiposViewModel> EquiposGetList3(int xd, int dx)
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.EquiposViewModel> lst = (from d in db.EquipoUnico
                                                                        where d.Tipo_ArticuloID_Articulo == xd && d.Inventario_LabID_Lab == dx && d.Activo == true
                                                                       select new Models.ViewModels.EquiposViewModel
                                                                        {
                                                                            ID_Equipo = d.ID_Equipo,
                                                                            Num_Serie = d.Num_Serie,
                                                                            Activo = d.Activo,
                                                                            Tipo_ArticuloID_Articulo = d.Tipo_ArticuloID_Articulo,
                                                                            Inventario_LabID_Lab = d.Inventario_LabID_Lab
                                                                        }).ToList();
                return lst;
            }
        }
        #endregion
    }
}
