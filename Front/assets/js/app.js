const cursor = document.querySelector('.cursor');

        document.addEventListener('mousemove', e => {
            cursor.setAttribute("style", "top: "+(e.pageY - 14)+"px; left: "+(e.pageX - 14)+"px;")
        })


        