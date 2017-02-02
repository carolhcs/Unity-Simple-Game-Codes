#pragma strict
function OnGUI(){
    if(GUI.Button(Rect(Posição X, Posição Y, Largura do Botão, Altura do botão), "Texto do botão")){
        Application.LoadLevel("GameFase01");
    }
    if(GUI.Button(Rect(Screen.width/2, 300,100,70), "Sair")){
        Application.Quit();
    }

}