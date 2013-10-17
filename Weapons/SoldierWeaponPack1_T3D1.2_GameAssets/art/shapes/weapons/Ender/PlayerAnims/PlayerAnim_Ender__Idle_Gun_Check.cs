singleton TSShapeConstructor(PlayerAnim_Ender__Idle_Gun_CheckDAE)
{
   baseShape = "./PlayerAnim_Ender__Idle_Gun_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender__Idle_Gun_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "_Idle_Gun_Check", "560", "649");
}
