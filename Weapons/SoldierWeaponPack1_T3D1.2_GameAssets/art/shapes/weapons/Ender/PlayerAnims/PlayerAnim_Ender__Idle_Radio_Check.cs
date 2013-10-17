singleton TSShapeConstructor(PlayerAnim_Ender__Idle_Radio_CheckDAE)
{
   baseShape = "./PlayerAnim_Ender__Idle_Radio_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender__Idle_Radio_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "_Idle_Radio_Check", "680", "790");
}
