<template>
  <div>
    Welcome To books {{ name }}
    Counter: {{ count }}
    <button @click="incrementFunc">Increment</button>
  </div>
</template>

<script lang="ts" src="./HelloWorld">
// import { onMounted } from 'vue';
// import { name, count, incrementFunc } from './HelloWorld'
// import { Options, Vue } from 'vue-class-component';

// onMounted(() => {
//   console.log("WELCOME")
// })

// @Options({
//   props: {
//     msg: String
//   }
// })
// export default class HelloWorld extends Vue {
//   msg!: string
// }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #42b983;
}
</style>
