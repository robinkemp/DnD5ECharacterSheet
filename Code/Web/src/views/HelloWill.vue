<template>
  <div class="home">
    <Spells />
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import Spells from "@/components/Spells.vue"; // @ is an alias to /src

@Component({
  components: {
    Spells
  }
})
export default class HelloWill extends Vue {}
</script>
