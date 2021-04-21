<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
<html>
<head></head>
   <body>
    <h1>Demografia en Chiapas</h1>
      <table>
      <tr><th>Ciudad</th><th>Habitantes</th></tr>
       <xsl:for-each select="ciudades/ciudad">
         <tr>
         <td><xsl:value-of select="nombre"></xsl:value-of></td>
         <td><xsl:value-of select="habitantes"></xsl:value-of></td>
         </tr>
       </xsl:for-each>
     </table>
   </body>
</html>  
  </xsl:template>
</xsl:stylesheet>
