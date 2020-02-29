<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
    <title>Modificar</title>
</head>
<body>
   <form action="/Video/ModificarVideo" method="post">
        <fieldset>
        <legend> Datos video</legend>
        <label for="idVideo">No.video:</label>
        <input type="text" name="idVideo" />
        <br />

        <label for="titulo">Titulo:</label>
        <input type="text" name="titulo" />
        <br />

        <label for="reproducciones">Reproducciones:</label>
        <input type="text" name="reproducciones" />
        <br />

        <label for="url">URL:</label>
        <input type="text" name="url" />
        <br />
        <input type="submit" name="modificarVideo" value="Modificar Video" />
        </form>
</body>
</html>
