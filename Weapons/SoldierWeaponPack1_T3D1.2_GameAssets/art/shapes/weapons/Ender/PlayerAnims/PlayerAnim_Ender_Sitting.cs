singleton TSShapeConstructor(PlayerAnim_Ender_SittingDAE)
{
   baseShape = "./PlayerAnim_Ender_Sitting.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_SittingDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sitting", "1230", "1235");
}
