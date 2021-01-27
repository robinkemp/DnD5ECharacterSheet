<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/witches-hat.png" />
    <HelloWitches msg="Welcome Witches" />
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import HelloWitches from "@/components/HelloWitches.vue"; // @ is an alias to /src

@Component({
  components: {
    HelloWitches
  }
})
export default class Home extends Vue {}
</script>
