singleton TSShapeConstructor(PlayerAnim_Ender_RunDAE)
{
   baseShape = "./PlayerAnim_Ender_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "140", "159");
}
