singleton TSShapeConstructor(PlayerAnim_Lurker_FallDAE)
{
   baseShape = "./PlayerAnim_Lurker_Fall.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "1040", "1069");
}
