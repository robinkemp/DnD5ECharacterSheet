<template>
  <v-app>
    <v-app-bar app color="primary" dark>
        <v-img
          :src="require('./assets/EmberAces.png')"
          contain
          height="75"
        />
       
    </v-app-bar>

    <v-main>
      <router-view></router-view>
    </v-main>

      <v-footer>
        <router-link to="/">Home</router-link>
        <v-spacer></v-spacer>
        <router-link to="player">Player</router-link>
        <v-spacer></v-spacer>
        <router-link to="about">About</router-link>
        <v-spacer></v-spacer>
        <router-link to="will">Spells</router-link>
      </v-footer>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "App",
  components: {},
  data: () => ({
    //
  })
});
</script>
