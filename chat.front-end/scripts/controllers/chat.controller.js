chatsec.controller('ChatController', function($scope, $location, MensagemService, toastr, $localStorage, $interval) {
	$scope.controller = 'ChatController';
	$scope.mensagens = [];
	$scope.usuarioLocal = $localStorage.usuario || null;
	verificaUsuarioLogado();
	carregar();
	
	//function verificaUsuarioLogado() {
	//    if ($scope.usuarioLocal === null) {
	///        $location.url('/login');
	//    }
	//};		

	function carregar(){
		MensagemService.carregar().then(function(response){			
            $scope.mensagens = response.data;
        });
    };

	$interval(carregar, 5000);

	$scope.encerrarSessao = function() {
	        delete $localStorage.usuario;
	        $location.url('/login');	
	}

	$scope.enviarMensagem = function(mensagem){
			mensagem.Usuario = $localStorage.usuario;
			MensagemService.adicionar(mensagem).then(function (response) {
				carregar();
				$scope.novaMensagem = null;
			});
		}
});