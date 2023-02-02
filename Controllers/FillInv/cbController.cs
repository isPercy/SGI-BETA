﻿using System;
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

        //LISTA DE TODOS LOS LABORATORIOS
        public IEnumerable<Models.ViewModels.LabViewModel> LabGetList()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.LabViewModel> lst = (from d in db.Inventario_Lab
                                                                   select new Models.ViewModels.LabViewModel
                                                                   {
                                                                       ID_Lab = d.ID_Lab,
                                                                       Nom_Lab = d.Nom_Lab
                                                                   }).ToList();
                return lst;
            }
        }

        //LISTA DE TODOS LOS ARTICULOS
        public IEnumerable<Models.ViewModels.ArticuloViewModel> ArtGetList()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.ArticuloViewModel> lst = (from d in db.Tipo_Articulo
                                                                        select new Models.ViewModels.ArticuloViewModel
                                                                        {
                                                                            ID_Articulo = d.ID_Articulo,
                                                                            Nom_Articulo = d.Nom_Articulo
                                                                        }).ToList();
                return lst;
            }
        }

        ////MOSTRAR ARTICULOS DEPENDIENDO DEL LABORATORIO SELECCIONADO
        //public IEnumerable<Models.ViewModels.ArticuloViewModel> Art_por_Lab(int xd)
        //{
        //    using (Models.BD.Model_BDContainer db= new Models.BD.Model_BDContainer())
        //    {
        //        IEnumerable<Models.ViewModels.ArticuloViewModel> search= (from a in db.Tipo_Articulo
        //                                                                  join e in db.EquipoUnico on a.ID_Articulo equals e.Tipo_ArticuloID_Articulo
        //                                                                  join l in db.Inventario_Lab on e.Inventario_LabID_Lab equals l.ID_Lab
        //                                                                  where l.ID_Lab == xd
        //                                                                  //orderby a.Nom_Articulo descending
        //                                                                  select new Models.ViewModels.ArticuloViewModel
        //                                                                  {
        //                                                                      ID_Articulo = a.ID_Articulo,
        //                                                                      Nom_Articulo = a.Nom_Articulo
        //                                                                  }).ToList();

        //        return search;
        //    }
        //}
    }
}
