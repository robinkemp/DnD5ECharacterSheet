<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/witches-hat.png">
    <HelloWorld msg="Welcome witches"/>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWitches.vue'

export default {
  name: 'Home',
  components: {
    HelloWorld
  }
}
</script>
