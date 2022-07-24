

const subscribe = document.querySelector(".subscribe")

const subscribeBtn = document.querySelector(".subscribe-btn")

var formData = new FormData();
const handleSetEmail = (ev) => {
    ev.preventDefault();
   
    
    formData.append("Email", subscribe.value)
 
    axios.post("/home/subscribe", formData)
 

}

subscribeBtn.addEventListener("click",handleSetEmail)