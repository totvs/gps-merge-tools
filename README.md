# GPS-MERGE-TOOLS

## Objetivo
- Ferramenta para auxiliar no Merge entre versões.

## Parametrizações
- Deve-se mapear os caminhos atráves do botão de Configurações.
- Digitar para quais versões será realizado o merge.
- Colocar o caminho de um arquivo .csv contendo o nome dos arquivos comitados no TFS.

## Funcionamento
- Gera um .bat com o nome da versão.
- Rodando o .bat, ele irá realizar a cópia dos arquivos adicionados, exclusão de arquivos deletados e abrir o WinMerge para os arquivos que foram alterados para realização do merge manual.
- Após isso, irá realizar o checkout de forma automática no TFS.