singleton TSShapeConstructor(PlayerAnim_Ender_FallDAE)
{
   baseShape = "./PlayerAnim_Ender_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "940", "969");
}
