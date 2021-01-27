<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <div class="d-flex align-center">
        I just wanna be a witch
      </div>

      <v-spacer></v-spacer>

      <v-btn
        href="https://github.com/vuetifyjs/vuetify/releases/latest"
        target="_blank"
        text
      >
        <span class="mr-2">Latest Release</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>

    <v-main>
      <HelloWitches />
    </v-main>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import HelloWitches from "./components/HelloWitches.vue";

export default Vue.extend({
  name: "App",

  components: {
    HelloWitches
  },

  data: () => ({
    //
  })
});
</script>
