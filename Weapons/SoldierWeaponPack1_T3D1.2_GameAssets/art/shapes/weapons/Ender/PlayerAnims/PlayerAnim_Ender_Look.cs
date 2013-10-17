singleton TSShapeConstructor(PlayerAnim_Ender_LookDAE)
{
   baseShape = "./PlayerAnim_Ender_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "820", "830");
}
