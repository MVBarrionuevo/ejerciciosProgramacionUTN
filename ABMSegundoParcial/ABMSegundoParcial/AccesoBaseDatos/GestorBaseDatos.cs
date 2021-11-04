using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ABMSegundoParcial.AccesoBaseDatos
{
    public class GestorBaseDatos
    {

        //public void agregarauto(auto auto)
        //{
        //    sqlconnection conexion = new sqlconnection(configurationmanager.connectionstrings["basedatos"].connectionstring);

        //    try
        //    {
        //        var sql = "insert into autos(patente, idmarca, km, promocion, precio) values(@patente, @id, @km, @promocion, @precio)";

        //        conexion.open();
        //        sqlcommand cmd = new sqlcommand(sql, conexion);

        //        cmd.parameters.addwithvalue("@patente", auto.patente);
        //        cmd.parameters.addwithvalue("@id", auto.idmarca);
        //        cmd.parameters.addwithvalue("@km", auto.km);
        //        cmd.parameters.addwithvalue("@promocion", auto.promocion);
        //        cmd.parameters.addwithvalue("@precio", auto.precio);

        //        cmd.executenonquery();
        //    }
        //    catch (exception exception)
        //    {

        //    }
        //    finally
        //    {
        //        conexion.close();
        //    }
        //}

        ////para el combobox:
        //public list<marca> listadomarcas()
        //{
        //    var lista = new list<marca>();

        //    var sql = "select * from marcas";

        //    sqlconnection conexion = new sqlconnection(configurationmanager.connectionstrings["basedatos"].connectionstring);
        //    conexion.open();
        //    sqlcommand cmd = new sqlcommand(sql, conexion);
        //    sqldatareader dr = cmd.executereader();

        //    while (dr.read())
        //    {
        //        marca marca = new marca();

        //        marca.nombre = (string)dr["nombre"];
        //        marca.id = (int)dr["idmarca"];

        //        lista.add(marca);
        //    }
        //    dr.close();
        //    conexion.close();
        //    return lista;
        //}

        ////dto para lo que me pidan hacer de consigna:

        ////metodo que me lista los autos con una condicion
        //public list<dtoauto> listadoautos()
        //{
        //    var lista = new list<dtoauto>();

        //    var sql = @"select idauto, patente, nombre, km, promocion, precio, (precio -(precio * 10)/100) as 'precio promocion'
        //                from autos a
        //                join marcas m on a.idmarca = m.idmarca
        //                where a.promocion = 1";


        //    sqlconnection conexion = new sqlconnection(configurationmanager.connectionstrings["basedatos"].connectionstring);
        //    conexion.open();
        //    sqlcommand cmd = new sqlcommand(sql, conexion);
        //    sqldatareader dr = cmd.executereader();

        //    while (dr.read())
        //    {
        //        dtoauto auto = new dtoauto();

        //        auto.idauto = (int)dr["idauto"];
        //        auto.patente = (string)dr["patente"];
        //        auto.marca = (string)dr["nombre"];
        //        auto.km = (int)dr["km"];
        //        auto.promocion = (bool)dr["promocion"];
        //        auto.precio = (double)dr["precio"];
        //        auto.preciopromocion = (double)dr["precio promocion"];

        //        lista.add(auto);
        //    }
        //    dr.close();
        //    conexion.close();
        //    return lista;
        //}

        ////metodo que me trae solamente una fila
        //public dtoautomasnuevo autousadomasnuevo()
        //{
        //    dtoautomasnuevo amasnuevo = null;

        //    var sql = @"select top 1 idauto, patente, nombre, precio, km, min(km)
        //                from autos a
        //                join marcas m on m.idmarca = a.idmarca
        //                where km > 0
        //                group by idauto, patente, nombre, precio, km
        //                order by min(km) asc";

        //    sqlconnection conexion = new sqlconnection(configurationmanager.connectionstrings["basedatos"].connectionstring);
        //    conexion.open();
        //    sqlcommand cmd = new sqlcommand(sql, conexion);
        //    sqldatareader dr = cmd.executereader();

        //    if (dr.read())
        //    {
        //        amasnuevo = new dtoautomasnuevo();

        //        amasnuevo.idauto = (int)dr["idauto"];
        //        amasnuevo.patente = (string)dr["patente"];
        //        amasnuevo.marca = (string)dr["nombre"];
        //        amasnuevo.km = (int)dr["km"];
        //        amasnuevo.precio = (double)dr["precio"];

        //    }
        //    dr.close();
        //    conexion.close();
        //    return amasnuevo;
        //}
    }
}