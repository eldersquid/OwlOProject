var sendBtn = document.getElementById('sendBtn');
var textBox = document.getElementById('textbox');
var chatContainer = document.getElementById('ChatBot_messages')
var user = {message : ""};

var grammar_articles = ["a","an","the"]

class InteractiveChatbox {
    constructor(a, b, c) {
        this.args = {
            button: a,
            chatbox: b
        }
        this.icons = c;
        this.state = false;
    }

    display() {
        const {button, chatbox} = this.args;

        button.addEventListener('click', () => this.toggleState(chatbox))
    }

    toggleState(chatbox) {
        this.state = !this.state;
        this.showOrHideChatBox(chatbox, this.args.button);
    }

    showOrHideChatBox(chatbox, button) {
        if(this.state) {
            chatbox.classList.add('chatbox--active')
            chatbox.style.display = "block";
            chatbox.style.transition = "all .5s ease-in-out;"
            this.toggleIcon(true, button);
        } else if (!this.state) {
            chatbox.classList.remove('chatbox--active')
            chatbox.style.display = "none";
            chatbox.style.transition = "all .5s ease-in-out;"
            this.toggleIcon(false, button);
        }
    }

    toggleIcon(state, button) {
        const { isClicked, isNotClicked } = this.icons;
        let b = button.children[0].innerHTML;

        if(state) {
            button.children[0].innerHTML = isClicked;
        } else if(!state) {
            button.children[0].innerHTML = isNotClicked;
        }
    }
}

textBox.addEventListener("keyup", function(event) {
    if (event.keyCode === 13) {
     event.preventDefault();
     document.getElementById("sendBtn").click();
    }
  });

function sendMessage(userMessage){
    var ChatContain = document.createElement('div');
    ChatContain.classList.add("messages__item");
    ChatContain.classList.add("messages__item--operator");
    ChatContain.setAttribute("id","Yes");
    ChatContain.innerHTML = "<span>" + userMessage + "</span>"
    chatContainer.appendChild(ChatContain);
    document.getElementById("ChatBot_Footer").scrollIntoView();



}

function loading(){
    var responseTimer = document.createElement('div');
    responseTimer.classList.add("messages__item");
    responseTimer.classList.add("messages__item--typing");
    var dots = document.createElement("span");
    dots.classList.add("messages__dot");
    responseTimer.appendChild(dots);
    chatContainer.appendChild(responseTimer);
    setTimeout(() => { responseTimer.remove() }, 1000)


}


function wordFilter(word){
    var removePunctuation = word.replace(/\b[-.,()&$#!\[\]{}"']+\B|\B[-.,()&$#!\[\]{}"']+\b/g, "");
    var LowerCaseWord = removePunctuation.toLowerCase();
    console.log(removePunctuation);





}

function chuuResponse(responseJson){
    var responseMessage = responseJson.answer;
    var response_array = responseMessage.split(" ");
    var link="";

    if (response_array.includes("<link>")) {
        var link = response_array[(response_array.length)-1];
        response_array.pop((response_array.length)-1)
        response_array.pop((response_array.length)-1)
        console.log(link);
        responseMessage = response_array.join(" ");
        console.log(responseMessage);
    }

    var ChatContain = document.createElement('div');
    ChatContain.classList.add("messages__item");
    ChatContain.classList.add("messages__item--visitor");
    if (link !=""){

        var chatLink = document.createElement('a');
        chatLink.innerText = "Here";
        chatLink.setAttribute("href",link)

        ChatContain.innerHTML = "<span>" + responseMessage + "</span>"
    } else {
        ChatContain.innerHTML = "<span>" + responseMessage + "</span>"

    }
    setTimeout(() => { loading() }, 1000)
    setTimeout(() => {
        ChatContain.animate([{easing:"ease-in",opacity:0.0},{opacity:1}],{duration:500})
        chatContainer.appendChild(ChatContain);
        if (link !=""){
            chatContainer.appendChild(chatLink);

        }
        document.getElementById("ChatBot_Footer").scrollIntoView();
    }, 2000)





}

function chuuSend(userMessage){
    // var url= 'rooms/chuuSend';
    var test_data = {"query" : userMessage};
    var test_data2 =JSON.stringify(test_data);
    console.log("test data is ",test_data)
    console.log("abc",userMessage)
    $.ajax({
		url: '/intent/DetectIntent',
		data: test_data,
		type: 'POST'
	}).done(function(result) {
        chuuResponse(result);
        console.log(result);
    }).fail(function(jqXHR, textStatus, errorThrown) {
        console.log("fail: ",textStatus, errorThrown);
        console.log(jqXHR);
    });







    // fetch(url, {
    //     method : "POST",
    //     body : userMessage


    // }).then(res => res.json())
    // .then(response =>{
    //     console.log(response);
    // });


    }



sendBtn.addEventListener('click',function(e){
    var userMessage = textBox.value;
    if (!userMessage == ""){
        user.message = userMessage.trim();
        sendMessage(userMessage.trim());
        // chuuResponse(userMessage.trim());
        chuuSend(userMessage);
        textBox.value = "";


    }




});
