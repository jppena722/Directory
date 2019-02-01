SELECT        colaboradores.idcodigocolaborador, colaboradores.nombrescolaborador, colaboradores.apellidoscolaborador, colaboradores.numerodocumentocolaborador, colaboradores.correocolaborador, colaboradores.movilcolaborador, 
                         estados.nombreestado, tipodocumentos.nombretipodocumento, roles.nombrerol
FROM            colaboradores
INNER JOIN estados ON estados.idestado = colaboradores.idestadocolaborador
INNER JOIN tipodocumentos ON tipodocumentos.idtipodocumento = colaboradores.idtipodocumentocolaborador
INNER JOIN roles ON roles.idrol = colaboradores.idrolcolaborador
 