# Processo-Seletivo-Esig

Projeto desenvolvido para cadastros de pessoas e cálculos de vencimentos 

Instruções de instalação e uso do projeto.

Instalação:

 Passo 1: 
	Clonar o repositório através do link: https://github.com/VanessaEugenio/Processo-Seletivo-Esig.git
 Passo 2:
	Executar o arquivo que se encontra na pasta PS_Esig com o nome PS_Esig.sln
 Passo 3: 
	Definir o Projeto PS_Esig como projeto de inicialização e o arquivo CadastroPessoas.aspx como Página inicial
 Passo 4: 
	No projeto PS_Esig, no web config setar a connectionString com o localhost do banco de dados sql server 
 Passo 5:
	Executar as procedures que estão nos arquivos: Procedure de calculo individual das rubricas.txt
													Procedure de recalculo geral.txt
													Procedure para criacao de contra cheque
													Procedure de listagem Total de pessoas e rubricas
													
Uso do projeto

 Passo 1:
	No botão cadastrar na aba esquerda:
		Inserção de mais um funcionário ao banco de dados, após o preenchimento dos textViews clicar no botão cadastrar. 
		somente irá prosseguir se todos os textviews estiverem preenchidos
 Passo 2:
	Na tela de cadastrar, no botão calcular é realizado o cálculo da rúbrica para o funcionário e apresentado em uma listagem. Apresentando os valores inerentes ao cargo selecionado. 
 Passo 3:
	No botão voltar, no topo ao lado direito da imagem Esig:
	Voltar a tela inicial e clicar no botão Listar para ver o funcionário inserido no botão cadastrar
 Passo 4:
	Na tela ListarPessoas é apresentado as rubricas calculadas e não calculadas onde recebem o valor 0 nas colunas de vencimentos,descontos,líquido. 
	A listagem retorna os botões  editar,excluir,recalcular e imprimir o contra cheque.
 Passo 5:	
	No Botão Editar: permite ao usuário editar/atualizar os dados pessoais inseridos na tela cadastroPessoa, ao ser clicado será direcionado a tela de cadastro com os textviews preenchidos, 
  no entanto, nessa tela será atualizado os dados e em seguida clicar no botão editar para realizar a alteração
	No botão excluir: permite ao usuário exluir o funcionário da rubrica.
	No botão recalcular: Assim como o botão editar, neste botão será selecionado o novo cargo e possibilitará realizar o recálculo individual clicando no botão recalcular.
	No botão Contra-cheque: Retorna o contra cheque do funcionário em questão. No contra cheque contém dados dos vencimentos,descontos e o valor líquido a receber.
	No botão recalcular geral: Da mesma forma que o botão recalcular individual, a ação desse botão consiste em calcular/recalcular todas rubricas que não foram calculadas no momento da inserção do funcionário
	
  
 

 
	