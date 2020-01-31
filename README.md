# GPS-MERGE-TOOLS

## Objetivo
- Ferramenta para auxiliar no Merge entre versões.<br/>
![Ferramenta](Images/Program.png?raw=true "Ferramenta")

## Parametrizações
- Deve-se mapear os caminhos atráves do botão de Configurações.<br/>
![Configuration of paths](Images/Config.png?raw=true "Configuration of paths")
- Digitar para quais versões será realizado o merge.<br/>
![Add version](Images/Version.png?raw=true "Add version")
- Colocar o caminho de um arquivo .csv contendo o nome dos arquivos comitados no TFS.<br/>
![CSV file with the file paths of TFS](Images/Csv%20of%20files.png?raw=true "CSV file with the file paths of TFS")<br/>
Exemplo: https://github.com/totvs/gps-merge-tools/tree/master/Example/test.csv

## Funcionamento
- Gera um .bat com o nome da versão no diretorio configurado.
- Rodando o .bat, ele irá realizar a cópia dos arquivos adicionados, exclusão de arquivos deletados e abrir o WinMerge para os arquivos que foram alterados para realização do merge manual.
- Caso a opção 'Rodar .bat após geração' esteja habilitada o .bat será executado no termino do processo.
- Após isso, irá realizar o checkout de forma automática no TFS.