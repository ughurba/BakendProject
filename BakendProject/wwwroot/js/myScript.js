
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

//--------------basket--------------///


const basketItem = document.querySelectorAll(".basketItem")


basketItem.forEach(btn => {
   
    const handleAddItemToBasket = (ev) =>
    {
    
        ev.preventDefault();
        const dataIdProduct = btn.getAttribute("data-id")
        var formData = new FormData();
        formData.append("id", dataIdProduct)
        axios.post("/basket/additem", formData)
    }



    btn.addEventListener("click",handleAddItemToBasket)
})

const countProduct = document.querySelectorAll(".countProduct")
const plusBtn = document.querySelectorAll(".plusBtn")
const sum = document.querySelectorAll(".total-amount");
const minusBtn = document.querySelectorAll(".minusBtn");
const removeBtn = document.querySelectorAll(".removeBtn");

removeBtn.forEach(item => {

    async function handleRemoveElement(ev) {
        ev.preventDefault();
        const removeId = item.getAttribute("data-id")
        try {
            const { data } = await axios.get("/basket/remove?id=" + removeId)
            this.parentElement.parentElement.parentElement.remove();
        } catch (err) {
            alert(err)
        }
       
    }

    item.addEventListener("click",handleRemoveElement)
})

minusBtn.forEach(item => {


    const dataIdProduct = item.getAttribute("data-id")

    item.addEventListener("click", async () => {
        const { data } = await axios.get("/basket/minus?id=" + dataIdProduct)


        countProduct.forEach(value => {
            const productId = value.getAttribute("data-id")
            if (productId == dataIdProduct) {

                if (data.count >= 1) {
                    value.value = data.count
                    sum.forEach(s => {
                        const sumId = s.getAttribute("data-id")
                        console.log(data)
                        console.log(s)
                        if (sumId == dataIdProduct) {
                            s.innerHTML = "€" + data.sum
                        }
                    })

                } 


            }

        })

    })


})

plusBtn.forEach(item => {
    
    const dataIdProduct = item.getAttribute("data-id")
    item.addEventListener("click", async () => {
        const { data } = await axios.get("/basket/plus?id=" + dataIdProduct)

        
        countProduct.forEach(value => {
            const productId = value.getAttribute("data-id")
            if (productId == dataIdProduct) {
           
                if (data.count <= data.productCount) {
                    value.value = data.count
                    sum.forEach(s => {
                        const sumId = s.getAttribute("data-id")
                        console.log(data)
                        console.log(s)
                        if (sumId == dataIdProduct) {
                            s.innerHTML = "€" + data.sum
                        }
                    })
                   
                } else {
                    alert("olmaz")
                }


            }

            })

       


    })
})


