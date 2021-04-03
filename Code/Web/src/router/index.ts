import Vue from "vue";
import VueRouter, { RouteConfig } from "vue-router";
import { authGuard } from "../auth/authGuard";
import Home from "../views/Home.vue";
import HelloWill from "../views/HelloWill.vue";

Vue.use(VueRouter);

const routes: Array<RouteConfig> = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/will",
    name: "HelloWill",
    component: HelloWill
  },
  {
    path: "/about",
    name: "About",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/About.vue")
  },
  {
    path: "/register",
    name: "Register",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../register/register-container.vue"),
      //beforeEnter: (to, from, next) => authGuard(to, from, next)
  },
  {
    path: "/player",
    name: "Player",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../player/player-container.vue"),
    beforeEnter: (to, from, next) => authGuard(to, from, next)
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
