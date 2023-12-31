import { Ref, defineComponent, onMounted, ref, watch } from 'vue'

// const name = ref("Fani")
// const count = ref(0)

// const incrementFunc = () => {
//     count.value++;
// }

// export { name, count, incrementFunc }

const initialLoad = (name: Ref) => {
    console.log("MOUNTED")
    setTimeout(() => {
        name.value = "Keorapetse Fani"
    }, 3000)
}

const incremement = (count: Ref) => {
    count.value++
}

export default defineComponent({
    setup() {
        const name = ref("Fani")
        const count = ref(0)

        onMounted(() => {
            initialLoad(name)
        })

        watch(name, (newVal) => {
            console.log(newVal)
        })

        return { name, count, incrementFunc: () => incremement(count) }
    },
})