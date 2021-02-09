<template>
  <v-container>
    <v-row class="text-center">
      <v-col cols="12">
        <v-img
          :src="require('../assets/witches-hat.png')"
          class="my-3"
          contain
          height="200"
        />
      </v-col>

      <v-col class="mb-4">
        <h1 class="display-2 font-weight-bold mb-3">Welcome to Witches Hat</h1>

        <p>
          Step into the world of Dungeons and Dragons with our Character Sheets
          and Levelling Up Guides
        </p>
        <p class="subheading font-weight-regular"></p>
        <p>
          For help and collaboration with other witches,
          <br />please join our online
          <a href="javascript: alert('Hello impatient')">Discord Community</a>
        </p>
        <p><span style="color:white">Rachel is awesome!</span></p>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "HelloWitches"
});
</script>
