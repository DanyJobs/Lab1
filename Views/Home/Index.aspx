<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
    <title>Index</title>
</head>
<body>
    <div>
        <h1> Opciones Video</h1>
        <br />
        <a href="/Video/Index">Ver Videos</a>
          <br />
            <br />
        <a href="/Video/Agregar" >Agregar Video</a>
          <br />
            <br />
        <a href="/Video/Modificar">Modificar</a>
          <br />
            <br />
        <a href="/Video/Eliminar">Eliminar</a>
    </div>
</body>
</html>
