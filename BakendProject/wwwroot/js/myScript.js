
const subscribe = document.querySelector(".subscribe")

const subscribeBtn = document.querySelector(".subscribe-btn")


const handleSetEmail = (ev) => {
    ev.preventDefault();
    var formData = new FormData();

    formData.append("Email", subscribe.value)
    console.log(formData)
    axios.post("/home/subscribe", formData).then(() => { alert("nices") }).catch(() => { alert("error") })


}

subscribeBtn.addEventListener("click", handleSetEmail)



///-----------------------------------------///\
const sortRow = document.getElementById("sort")
const sortRowPage2 = document.getElementById("list")
async function  myFunction()  {
    var value = document.getElementById("mySelect").value
  
    const { data} = await axios.get("/shop/Sort?take=" + value)
   // const  dataPageTwo  = await axios.get("/shop/SortTwoPage?take=" + value)
/*     sortRowPage2.innerHTML = dataPageTwo.data*/
     sortRow.innerHTML = data
}


async function SortMinMax() {
    const minMax = document.getElementById("sortMinMax").value
    const { data } = await axios.get("/shop/SortMinMax?min=" + minMax)
 //  const dataPageTwo = await axios.get("/shop/SortMinMaxPageTwo?min=" + minMax)
 
    sortRow.innerHTML = data
/*    sortrowpage2.innerhtml = dataPageTwo.data*/
    

}


const btnSubProduct = document.querySelectorAll(".subBtnProduct")

const detailContent = document.querySelector(".detail-content")

    btnSubProduct.forEach(item => {

        const handleShowDetail = async () => {
           
            const dataIdBtnSub = item.getAttribute("data-id")

            const { data} = await axios.get("/shop/detailtwo?id=" + dataIdBtnSub)
            
            detailContent.innerHTML = data
        }

        item.addEventListener("click", handleShowDetail)
    })
const tabContent = document.querySelector(".tab-content")
btnSubProduct.forEach(item => {

    const handleShowDetail = async () => {

        const dataIdBtnSub = item.getAttribute("data-id")

        const { data } = await axios.get("/shop/DescComment?id=" + dataIdBtnSub)

        tabContent.innerHTML = data
    }

    item.addEventListener("click", handleShowDetail)
})




