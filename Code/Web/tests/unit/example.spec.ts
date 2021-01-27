import { shallowMount } from "@vue/test-utils";
import HelloWitches from "@/components/HelloWitches.vue";

describe("HelloWitches.vue", () => {
  it("renders props.msg when passed", () => {
    const msg = "new message";
    const wrapper = shallowMount(HelloWitches, {
      propsData: { msg }
    });
    expect(wrapper.text()).toMatch(msg);
  });
});
