<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
<html>
<head></head>
   <body>
    <h1>Modelos mas costosos de motos</h1>
      <table>
      <tr><th>Modelo</th><th>Precio</th></tr>
       <xsl:for-each select="motos/modelo">
         <tr>
         <td><xsl:value-of select="nombre"></xsl:value-of></td>
         <td><xsl:value-of select="costo"></xsl:value-of></td>
         </tr>
       </xsl:for-each>
     </table>
   </body>
</html>  
  </xsl:template>
</xsl:stylesheet>